using Away.Api.Misc.Extensions;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Away.Api.Misc.Export
{
    public class ExcelExport<TData>
    {
        #region Private Attributes
        private readonly IEnumerable<TData> _dataToExport;
        private readonly IEnumerable<string> _propertiesToIgnore;
        private readonly Dictionary<string, string> _fieldsName;
        private readonly List<PropertyInfo> _fieldsInfo;
        private readonly Dictionary<TypeCode, ICellStyle> _cellStyles;
        #endregion

        #region Constructors
        public ExcelExport(IEnumerable<TData> dataToExport, IEnumerable<string> propertiesToIgnore = null, Dictionary<string, string> fieldsName = null)
        {
            _dataToExport = dataToExport;
            _propertiesToIgnore = propertiesToIgnore ?? new List<string>();
            _fieldsName = fieldsName ?? new Dictionary<string, string>();
            _fieldsInfo = typeof(TData).GetProperties().ToList();
            _cellStyles = new Dictionary<TypeCode, ICellStyle>();
        }
        #endregion

        #region Public Methods
        public byte[] ExecuteResult()
        {
            byte[] result = null;

            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("DataExport");

            //Inicializamos los estilos disponibles
            InitializeCellStyles(ref workbook);

            //Cargamos encabezado
            LoadHeader(ref sheet, ref workbook);

            //Cargamos los registros
            if (_dataToExport.Count() > 0)
                LoadBody(ref sheet, ref workbook);

            using (var ms = new MemoryStream())
            {
                workbook.Write(ms);
                result = ms.ToArray();
            }

            return result;
        }
        #endregion

        #region Private Helpers
        private void InitializeCellStyles(ref HSSFWorkbook workbook)
        {
            //Creamos estilo de celda de tipo string
            var cellDataStyle = workbook.CreateCellStyle();
            cellDataStyle = workbook.CreateCellStyle();
            cellDataStyle.Alignment = HorizontalAlignment.Left;

            //Creamos estilo de celda de tipo fecha
            var cellDateStyle = workbook.CreateCellStyle();
            cellDateStyle.DataFormat = workbook.CreateDataFormat().GetFormat("dd/MM/yyyy");

            //Creamos estilo de celda de tipo decimal
            var cellDecimalStyle = workbook.CreateCellStyle();
            cellDecimalStyle.Alignment = HorizontalAlignment.Right;
            cellDecimalStyle.DataFormat = workbook.CreateDataFormat().GetFormat("0.00");

            //Creamos estilo de celda de tipo boolean
            var cellBooleanStyle = workbook.CreateCellStyle();
            cellBooleanStyle.Alignment = HorizontalAlignment.Right;

            _cellStyles.Add(TypeCode.String, cellDataStyle);
            _cellStyles.Add(TypeCode.DateTime, cellDateStyle);
            _cellStyles.Add(TypeCode.Decimal, cellDecimalStyle);
            _cellStyles.Add(TypeCode.Double, cellDecimalStyle);
            _cellStyles.Add(TypeCode.Boolean, cellBooleanStyle);
        }
        private ICellStyle FormatHeader(ref HSSFWorkbook workbook)
        {
            var styleCell = workbook.CreateCellStyle();
            var styleFont = workbook.CreateFont();
            styleFont.Boldweight = (short)FontBoldWeight.Bold;
            styleCell.BorderTop = BorderStyle.Double;
            styleCell.BorderBottom = BorderStyle.Double;
            styleCell.BorderLeft = BorderStyle.Thin;
            styleCell.BorderRight = BorderStyle.Thin;
            styleCell.Alignment = HorizontalAlignment.Left;
            styleCell.SetFont(styleFont);
            return styleCell;
        }
        private void LoadHeader(ref ISheet sheet, ref HSSFWorkbook workbook)
        {
            var row = sheet.CreateRow(0);
            for (int iPos = 0; iPos < _fieldsInfo.Count; iPos++)
            {
                var fieldInfo = _fieldsInfo[iPos];
                if (_propertiesToIgnore.Contains(fieldInfo.Name))
                    continue;

                var fieldName = fieldInfo.Name;
                if (_fieldsName.ContainsKey(fieldInfo.Name))
                    fieldName = _fieldsName[fieldInfo.Name];

                var cell = row.CreateCell(iPos);
                cell.SetCellValue(fieldName);
                cell.CellStyle = FormatHeader(ref workbook);
            }
        }
        private void LoadBody(ref ISheet sheet, ref HSSFWorkbook workbook)
        {
            var rowIndex = 1;
            foreach (TData itemData in _dataToExport)
            {
                var row = sheet.CreateRow(rowIndex++);
                for (int iPos = 0; iPos < _fieldsInfo.Count; iPos++)
                {
                    var fieldInfo = _fieldsInfo[iPos];
                    if (_propertiesToIgnore.Contains(fieldInfo.Name))
                        continue;

                    var cell = row.CreateCell(iPos);
                    var value = fieldInfo.GetValue(itemData, null);
                    var strValue = (value != null) ? value.ToString() : string.Empty;
                    var typeCode = Type.GetTypeCode(value == null ? string.Empty.GetType() : value.GetType());

                    ICellStyle cellStyle = null;
                    if (!_cellStyles.TryGetValue(typeCode, out cellStyle))
                        _cellStyles.TryGetValue(TypeCode.String, out cellStyle);

                    cell.SetValue(ref workbook, ref cellStyle, typeCode, strValue);
                }
            }
        }
        #endregion
    }
}
