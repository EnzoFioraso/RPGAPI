using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Models
{
    public class Armas
    {
        public int Id { get ; set ;}
        public string Nome { get; set;}
        public int Dano { get; set;}
    }
}