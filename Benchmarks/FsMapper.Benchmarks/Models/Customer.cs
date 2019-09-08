﻿using System;

namespace FsMapper.Benchmarks.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public bool IsDeleted { get; set; }
    }
}