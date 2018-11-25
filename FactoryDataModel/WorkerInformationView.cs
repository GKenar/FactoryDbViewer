//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FactoryDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkerInformationView
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkerInformationView()
        {
            this.DailyAccount = new HashSet<DailyAccountView>();
        }
    
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string tableNumber { get; set; }
        public string department { get; set; }
        public string speciality { get; set; }
        public int category { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public System.DateTime workStartDate { get; set; }
        public int DepartmentId { get; set; }
        public int SpecialityId { get; set; }
    
        public virtual DepartmentsView Department { get; set; }
        public virtual WorkerSpecialitiesView Speciality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyAccountView> DailyAccount { get; set; }
    }
}
