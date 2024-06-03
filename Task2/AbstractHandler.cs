using System;
namespace AbstractClassesAndInterfaces;

/*
 * Створити клас AbstractHandler.
   У тілі класу створити методи 
   void Open(), void Create(), void Change(), void Save(). 
 */
public abstract class AbstractHandler
{
    public abstract void Open();
    public abstract void Create();
    public abstract void Change();
    public abstract void Save();
    
}