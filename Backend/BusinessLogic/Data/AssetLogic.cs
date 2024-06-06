using Backend.BusinessLogic.Interfaces;
using Backend.Context;
using Backend.Models;
using Backend.Repositories.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.BusinessLogic.Data
{
    public class AssetLogic : IAssetLogic
    {
        private DapperDBConteks _conteks;
        private IAssetRepository entity;

        public AssetLogic(DapperDBConteks conteks, IAssetRepository entity)
        {
            this._conteks = conteks;
            this.entity = entity;
        }

        private ResultAction MessageResult(bool bSuccess, string message)
        {
            return MessageResult(bSuccess, message, null);
        }

        private ResultAction MessageResult(bool bSuccess, string message, object objResult)
        {
            ResultAction result = new ResultAction()
            {
                bSuccess = bSuccess,
                ErrorNumber = (bSuccess ? "0" : "666"),
                Message = message,
                ResultObj = objResult
            };

            return result;

        }

        public ResultAction GetAll()
        {
            ResultAction result = new ResultAction();
            try
            {
                using (_conteks.CreateConnection())
                {
                    var existing = entity.Get();
                    result = MessageResult(true, "Success", existing);
                }
            }
            catch (Exception ex)
            {
                result = MessageResult(false, ex.Message);
            }
            return result;
        }
    }
}
