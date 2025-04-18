﻿using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IClienteRepository
    {
        // R - Read (Leitura) 
        // Retorno
        List<Cliente> ListarTodos();
        //Recebe um identificador, e retorna o produto correspondente
        Cliente BuscarPorId(int id);
        Cliente BuscarPorEmailSenha(string email, string senha);

        // C - Create (cadastro)
        void Cadastrar(Cliente cliente);

        // U - Update (Atualização)
        // Recebe um identificador para encontrar o Produto, e recebe o Produto Novo para subistituir o Antigo
        void Atualizar(int id, Cliente cliente);

        // D - Delete (Deleção)
        // Recebo o identificador de quem quero excluir
        void Deletar(int id);
    }
}