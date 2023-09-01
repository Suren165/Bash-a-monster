// See https://aka.ms/new-console-template for more information
using System.Reflection;
using BashMonster;
using Namespace;

Console.WriteLine("Hello, World!");



Fish wanda = new Fish();
wanda.ResetHp();
Fish henry = new Fish();
henry.ResetHp();

Hero Siu = new Hero();
Dragon pessi = new Dragon();




wanda.Damage = 100;
henry.Damage = 200;
Siu.damage = 50;
pessi.damage = 10;

Siu.HP = 50;

pessi.Weight = 1000;

Console.WriteLine(wanda.Damage);

Console.ReadLine();

