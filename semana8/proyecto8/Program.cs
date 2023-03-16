﻿using proyecto8.Models;

AlmacenContext db = new AlmacenContext();

Console.WriteLine("Ingrese el nombre del producto: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la descripción del producto: ");
string descripcion = Console.ReadLine();
Console.WriteLine("Ingrese el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el stock del producto: ");
int stock = int.Parse(Console.ReadLine());

// Insertar el producto en la base de datos
var producto = new Producto { Nombre = nombre, Descripcion = descripcion, Precio = precio, Stock = stock };
db.Productos.Add(producto);
db.SaveChanges();
