using CMSSolution.Entity.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMSSolution.Data.Repositories.Interface.Base
{
    //DIP'e uymadan yaptığımız projelerde tek bir interface oluşturmuştuk. Bu interfacedeki crud işlemlerini her varlık çin oluşturduğumuz EfRepositorylere tek tek kalıtım vermiştir. UI katmanında da Efrepositoryleri çağırdımıştık.
    //Lakin DIP'e uyduğumuz bu projede Her varlık için ayrı ayrı Interface tanımlamamız gerekecek çünkü  DIP'e göre UI katmanında Interfaceler tanımlanacak. 

    public interface IKernelRepository<T> where T:class, IBaseEntity
    {
        //Bu projede CRUD operasyonlarını "Task" olarak işaretleyeceğiz yani asenkron programing yapacağız.
        //Asenkron progromlama yapabilnek için CRUD operasyonları Task ile işaretlenir. 
        Task<List<T>> GetAll();
        Task<List<T>> Get(Expression<Func<T, bool>> expression); //Expression<Func<T, bool>> expression nedir? çağırdığımızda bunu ilgili metodun içine istediğimiz dinamik linq sorgusunu yazmamızı sağlar. Böylece istediğimiz lingto sorgusunu kullanabiliriz.
        Task<T> GetById(int id);

        Task<T> FirstOrDefault(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);

        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

        


    }
}
