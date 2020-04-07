using Away.Api.Core.Logger;
using Away.Api.Core.Repository;
using Away.Api.Core.Repository.Base;
using Away.Api.Data.Entities;
using Away.Api.Data.Repository;
using Away.Api.Misc.Extensions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Away.Api.Logger.Logic
{
    public class LoggerDb : ILogger
    {
        #region Constants
        private const string _SourceFormat = "Source: {0}/LineNumber: {1}/File: {2}";
        #endregion

        #region Private Attributes
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogRepository _repository;
        #endregion

        #region Constructors
        public LoggerDb(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = unitOfWork.RegisterRepository<LogRepository>();
        }
        #endregion

        #region ILogger
        public void Error(string origin, string message, Exception ex = null, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", bool global = false, bool generateMessage = true)
        {
            try
            {
                var logEntity = new LogModel();
                logEntity.Tipo = "E";
                logEntity.FechaCreacion = DateTime.UtcNow;

                if (ex != null)
                {
                    logEntity.Origen = origin;
                    logEntity.Descripcion = (!generateMessage && string.IsNullOrWhiteSpace(ex.Message)) ? message : ex.GetDescription();
                    logEntity.Detalle = ex.GetDetail();
                    logEntity.StackTrace = ex.GetStackTrace();
                    logEntity.Source = string.Format(_SourceFormat, sourceMember, lineNumber, filePath.GetResumePath()) + " || Exception Source: " + ex.Source;
                    logEntity.TargetSite = ex.TargetSite != null ? ex.TargetSite.Name : string.Empty;
                }
                else
                {
                    logEntity.Origen = origin;
                    logEntity.Source = string.Format(_SourceFormat, sourceMember, lineNumber, filePath);
                    logEntity.Descripcion = message;
                }

                //Grabamos en la base de datos
                _repository.Add(logEntity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                //Nothing to do...
            }
        }

        public void Info(string origin, string message, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            try
            {
                var logEntity = new LogModel();
                logEntity.Tipo = "I";
                logEntity.Origen = origin;
                logEntity.Source = string.Format(_SourceFormat, sourceMember, lineNumber, filePath.GetResumePath());
                logEntity.FechaCreacion = DateTime.UtcNow;
                logEntity.Descripcion = message;

                //Grabamos en la base de datos
                _repository.Add(logEntity);
            }
            catch (Exception)
            {
                //Nothing to do...
            }
        }

        public void Warning(string origin, string message, [CallerMemberName] string sourceMember = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "")
        {
            try
            {
                var logEntity = new LogModel();
                logEntity.Tipo = "W";
                logEntity.Origen = origin;
                logEntity.Source = string.Format(_SourceFormat, sourceMember, lineNumber, filePath.GetResumePath());
                logEntity.FechaCreacion = DateTime.UtcNow;
                logEntity.Descripcion = message;

                //Grabamos en la base de datos
                _repository.Add(logEntity);
            }
            catch (Exception)
            {
                //Nothing to do...
            }
        }
        #endregion
    }
}
