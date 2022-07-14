using KlinikaProjekt.Models;
using System.Collections;
using System.Collections.Generic;

namespace KlinikaProjekt.Data.ViewModels



{
    public class prodOrderVM
    {

        public IEnumerable<Pharmacy>pharmacies { get; set; }
        public IEnumerable<MedicamentOrder> medicamentOrders { get; set; }

    }
}
