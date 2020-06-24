using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class Client
    {
        public string SkinType { get; set; }

        public string NailService { get; set; }

        private readonly List<string> _appropriateFacials = new List<string>();

        public Client(string skinType, string nailService)
        {
            SkinType = skinType;
            NailService = nailService;
        }

        public List<string> GetFacials() => _appropriateFacials;        

        public bool CheckSkinType(string skinType, string facialType)
        {
            if (skinType == "oily" && facialType == "Microdermabrasion" || facialType == "Rejuvenating")               
                return true;                
            else if(skinType == "oily")
                return false; 
            else if (skinType == "combination" && (facialType == "Microdermabrasion" || facialType == "Rejuvenating" || facialType == "Enzyme Peel"))                          
                return true;                
            else if (skinType == "combination")
                return false;
            else if (skinType == "normal")            
                return true;            
            else if (skinType == "dry" && (facialType == "Rejuvenating" || facialType == "Hydrofacial"))               
                return true;                
            else if(skinType == "dry")              
                return false;  
            else            
                return true;            
        }

        public void SetFacials(String skinType)
        {
            List<string> facials = new List<String>
            {
                "Microdermabrasion",
                "Hydrofacial",
                "Rejuvenating",
                "Enzyme Peel"
            };

            foreach (string facial in facials)            
                if (CheckSkinType(skinType, facial))                
                    _appropriateFacials.Add(facial);
        }
    }
}
