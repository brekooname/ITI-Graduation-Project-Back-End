﻿

namespace Final.Project.BL;

public class ProductChildDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Image { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
}