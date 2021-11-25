﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingRegistrationAPI.ViewModel
{
    public class CourseVM
    {
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseDesc { get; set; }
        [Required]
        public string CourseFee { get; set; }
        [Required]
        public string CourseImg { get; set; }
        public int TopicId { get; set; }
        public int TrainerId { get; set; }
    }
}