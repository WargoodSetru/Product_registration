﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project_Database
{
    /// <summary>
    /// Шаблон дял создания пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? SurName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
    }
}








