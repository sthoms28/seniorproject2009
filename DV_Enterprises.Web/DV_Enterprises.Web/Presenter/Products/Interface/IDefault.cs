using System.Collections.Generic;
using DV_Enterprises.Web.Data.Domain;

namespace DV_Enterprises.Web.Presenter.Products.Interface
{
    public interface IDefault
    {
        void LoadData(List<Product> products);
    }
}