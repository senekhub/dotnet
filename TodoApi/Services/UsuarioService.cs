using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace TodoApi.Services{
    public class UsuarioService{
        private readonly IMongoCollection<Usuario> _usuarios;
        public UsuarioService(IConfiguration config)
        {
            var client=new MongoClient(config.GetConnectionString("mongo"));
            var db=client.GetDatabase("colegio");
            _usuarios=db.GetCollection<Usuario>("usuario");
        }
        public List<Usuario> Get(){
            return _usuarios.Find(todo=>true).ToList();
        }
        public Usuario Create(Usuario usuario){
            _usuarios.InsertOne(usuario);
            return usuario;
        }
    }
}