using System.Collections.Generic;

namespace Cadastro.Filmes.Interfaces
{
    public interface IRepositorio<T>
    {
        // tipos de funções que vão ser aplicadas no app
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}