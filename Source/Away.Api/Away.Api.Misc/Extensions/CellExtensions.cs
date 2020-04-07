using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Away.Api.Misc.Extensions
{
    public static class CellExtensions
    {
        #region Public Methods
        public static void SetValue(this ICell cellSheet, ref HSSFWorkbook workbook, ref ICellStyle cellStyle, TypeCode typeData, string value)
        {
            switch (typeData)
            {
                case TypeCode.DateTime:
                    var valueDateTime = default(DateTime);
                    DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out valueDateTime);
                    cellSheet.SetCellValue(valueDateTime);
                    cellSheet.CellStyle = cellStyle;
                    break;
                case TypeCode.Decimal:
                case TypeCode.Double:
                    var valueDouble = default(Double);
                    Double.TryParse(value, out valueDouble);
                    cellSheet.SetCellValue(valueDouble);
                    cellSheet.CellStyle = cellStyle;
                    break;
                case TypeCode.Boolean:
                    var valueBoolean = default(Boolean);
                    Boolean.TryParse(value, out valueBoolean);
                    cellSheet.SetCellValue(valueBoolean);
                    cellSheet.CellStyle = cellStyle;
                    break;
                default:
                    var valueString = value ?? string.Empty;
                    cellSheet.SetCellValue(valueString);
                    cellSheet.CellStyle = cellStyle;
                    break;
            };
        }

        public static string GetValue(this ICell cellSheet, TypeCode typeData)
        {
            var retorno = string.Empty;
            try
            {
                switch (typeData)
                {
                    case TypeCode.DateTime:
                        retorno = cellSheet.DateCellValue.ToString("dd/MM/yyyy");
                        break;
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                        retorno = cellSheet.NumericCellValue.ToString("0.000000000000000");
                        if (retorno.EndsWith("0"))
                        {
                            while (retorno.EndsWith("0"))
                                retorno = retorno.Substring(0, retorno.Length - 1);
                        }
                        break;
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                        retorno = cellSheet.NumericCellValue.ToString();
                        break;
                    case TypeCode.Boolean:
                        retorno = cellSheet.BooleanCellValue.ToString();
                        break;
                    default:
                        retorno = cellSheet.GetValue();
                        break;
                }
            }
            catch (Exception)
            {
            }
            return retorno;
        }

        public static TData GetValue<TData>(this ICell cellSheet, TypeCode typeData)
            where TData : class
        {
            var retorno = default(TData);
            try
            {
                switch (typeData)
                {
                    case TypeCode.DateTime:
                        retorno = cellSheet.DateCellValue as TData;
                        break;
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                        retorno = cellSheet.NumericCellValue as TData;
                        break;
                    case TypeCode.Boolean:
                        retorno = cellSheet.BooleanCellValue as TData;
                        break;
                    default:
                        retorno = cellSheet.GetValue() as TData;
                        break;
                }
            }
            catch (Exception)
            {
            }
            return retorno;
        }

        public static string GetValue(this ICell cellSheet)
        {
            var retorno = string.Empty;
            try
            {
                switch (cellSheet.CellType)
                {
                    case CellType.Blank:
                        break;
                    case CellType.Boolean:
                        retorno = cellSheet.BooleanCellValue.ToString();
                        break;
                    case CellType.Error:
                        break;
                    case CellType.Formula:
                        break;
                    case CellType.Numeric:
                        retorno = cellSheet.NumericCellValue.ToString();
                        break;
                    case CellType.String:
                        retorno = cellSheet.StringCellValue;
                        break;
                    case CellType.Unknown:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
            return retorno;
        }
        #endregion
    }
}
