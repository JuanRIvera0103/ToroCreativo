﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToroCreativo.Clases
{
    public class ProductoRegistroCompleto
    {
        //producto
        public int idProductos { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]     
        [StringLength(30)]
        [RegularExpression("^[A-Z][a-zA-ZñÑáéíóúÁÉÍÓÚ_ ]*$", ErrorMessage = "El nombre debe de comenzar con mayúscula, aparte de tener una letra más y solo debe de contener letras")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(500)]
        [RegularExpression("^[A-Z][a-zA-ZñÑáéíóúÁÉÍÓÚ_ ]*$", ErrorMessage = "La descripcioón debe de comenzar con mayúscula, aparte de tener una letra más y solo debe de contener letras")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La categoría es requerida")]
        public int Categoria { get; set; }    
        public string Estado { get; set; }

        //Característica
        [Required(ErrorMessage = "El color es requerido")]
        public string Color { get; set; }
        [Required(ErrorMessage = "La medida es requerida")]
        public int Medida { get; set; }

        //Precio   
        [DisplayName("Precio sin Iva")]
        [Required(ErrorMessage = "El precio es requerida")]  
        [RegularExpression("^[0-9]*$", ErrorMessage = "El precio solo debe de contener números enteros positivos")]        
        public double Valor { get; set; }

        //IVA
        [DisplayName("% Iva")]
        [Required(ErrorMessage = "El porcentaje de IVA es requerida")]
        [Range(0, 100, ErrorMessage = "El IVA debe de estar entre los porcentajes de 0 al 100")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "El IVA solo debe de contener números enteros positivos")]
        public double IVA { get; set; }

        //Imagen
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Imagen Principal del producto")]
        [Required(ErrorMessage = "La imagen principal del producto es requerida")]
        [RegularExpression("^.*.(jpg|png|jpeg)$", ErrorMessage = "La imagen solo permite formatos .jpg .png o .jpeg")]
        public IFormFile ImageFile { get; set; }
    }
}
