//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssistanceApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Results
    {
        public long Id_Result { get; set; }
        public long Id_Course { get; set; }
        public long Id_Trainee { get; set; }
        public System.DateTime Date { get; set; }
        public double Percents { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
