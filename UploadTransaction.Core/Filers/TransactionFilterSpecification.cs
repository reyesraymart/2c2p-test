using System.Linq.Expressions;
using UploadTransaction.Core.Entities;
using UploadTransaction.Core.Extensions;
using UploadTransaction.Core.Interfaces.Filters;

namespace UploadTransaction.Core.Filers
{
    public class TransactionFilterSpecification : IFilterSpecification<TransactionSearchRequestData, Transaction>
    {
        public Expression<Func<Transaction, bool>> GetExpression(TransactionSearchRequestData filterData)
        {
            var condition = ExpressionExtensions.Blank<Transaction>();
            
            condition = condition.AndIf(filterData.CurrencyCode != null, entity => filterData.CurrencyCode == entity.CurrencyCode);
            condition = condition.AndIf(filterData.From.HasValue, entity => entity.TransactionDate >= filterData.From);
            condition = condition.AndIf(filterData.To.HasValue, entity => filterData.To >= entity.TransactionDate);
            condition = condition.AndIf(filterData.Status.HasValue, entity => filterData.Status == entity.Status);

            return condition;
        }
    }
}