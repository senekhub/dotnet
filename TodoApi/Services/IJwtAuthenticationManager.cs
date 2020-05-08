using System;
using TodoApi.Models;

namespace TodoApi.Services{
    public interface IJwtAuthenticationManager{
        string Authenticate(Usuario usuario);
    }
}