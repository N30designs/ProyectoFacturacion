using facturacion.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion
{
    public enum TypeBusiness
    {
        CarSell,
        TreeProduction
    }

    public static class Factory
    {
        public static IClients GetClientObject(TypeBusiness eType)
        {
            switch(eType)
            {
                case TypeBusiness.CarSell:
                    return new Clientes();
                case TypeBusiness.TreeProduction:
                    return new ClientesBDRemota();
                    
            }
            return null;
        }
    }
}
