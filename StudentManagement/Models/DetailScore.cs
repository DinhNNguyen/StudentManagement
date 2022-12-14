//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Models
{
    using StudentManagement.ViewModels;
    using System;
    using System.Collections.Generic;
    
    public partial class DetailScore : BaseViewModel
    {
        private System.Guid _id { get; set; }
        public System.Guid Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idStudent { get; set; }
        public Nullable<System.Guid> IdStudent { get => _idStudent; set { _idStudent = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idComponentScore { get; set; }
        public Nullable<System.Guid> IdComponentScore { get => _idComponentScore; set { _idComponentScore = value; OnPropertyChanged(); } }
        private Nullable<double> _score { get; set; }
        public Nullable<double> Score { get => _score; set { _score = value; OnPropertyChanged(); } }
    
        public virtual ComponentScore ComponentScore { get; set; }
        public virtual Student Student { get; set; }
    }
}
