using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login3A1BRUNO06.Code.DTO
{
    class LoginDTO
    {
        private int _Id;
        private string _email;
        private string _senha;

        public int Id { get => _Id; set => _Id = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
