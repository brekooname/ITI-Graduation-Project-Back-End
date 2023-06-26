﻿using Final.Project.DAL;

namespace Final.Project.BL;

public class OrderReadDto
{
    public int Id { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DateTime? DeliverdDate { get; set; } = null;
    public string UserName { get; set; } = string.Empty;
}
