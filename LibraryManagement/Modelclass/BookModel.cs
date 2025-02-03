﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Modelclass
{
    public class BookModel

    {
        public int BookID 
        { 
            get;
            set; 
        }          
        public string Title { get; set; }         
        public string Author { get; set; }        
        public string Publisher { get; set; }     
        public int Year { get; set; }            
        public string Genre { get; set; }       
        public int CopiesAvailable { get; set; }  
        public string BookImage { get; set; }   
    }
    

}
