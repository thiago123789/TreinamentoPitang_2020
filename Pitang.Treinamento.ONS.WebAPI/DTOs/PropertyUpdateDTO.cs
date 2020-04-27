using System;
using System.Collections.Generic;

namespace Pitang.Treinamento.ONS.WebAPI.DTOs
{
    public class PropertyUpdateDTO
    {
        public int ObjectId { get; set; }

        public IList<PropertyInput> PropertiesToUpdate { get; set; }


        public PropertyUpdateDTO()
        {
        }

        //ObjectId = 1
        //PropertyName = "Nome"
        //PropertyValue = "Thiago"



    }

    public class PropertyInput
    {

        public string PropertyName { get; set; }

        public string PropertyValue { get; set; }
    }
}
