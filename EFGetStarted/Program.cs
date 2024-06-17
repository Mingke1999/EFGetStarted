using EFGetStarted;
using System.Collections.Generic;

Console.WriteLine("Hello World");

BlogContext context = new BlogContext();

//CREATE
//Blog blog = new() { Url = "http://baidu.com" };
//context.Blogs.Add(blog);
//context.SaveChanges();

//UPDATE
//var first = context.Blogs.FirstOrDefault();
////where id = first.id
//first.Url = "http://baidu.com";
//context.SaveChanges();

//DELETE
//context.Blogs.Remove(first);
//context.SaveChanges();
//READ
//var list = context.Blogs.ToList();
//Console.WriteLine(list.Count);

