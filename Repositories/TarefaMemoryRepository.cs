using System.Collections.Generic;
using TodoBackEnd.Models;
using System.Linq;

namespace TodoBackEnd.Repositories
{
    public class TarefaMemoryRepository : ITarefaRepository
    {
        public List<Tarefa> tarefas = new List<Tarefa>();

        public List<Tarefa> Read()
        {
            if (tarefas.Count == 0)
            {
                tarefas.Add(new Tarefa { Id = "1", Texto = "Alface", min = 35, max = 65, umidade = 37, umidadeSolo = 77, temperatura = 35, Finalizada = true });
                tarefas.Add(new Tarefa { Id = "2", Texto = "Rucula", min = 15, max = 85, umidade = 27, umidadeSolo = 59, temperatura = 34, Finalizada = false });
            }
            return tarefas;
        }

        public void Create(Tarefa model)
        {
            tarefas.Add(model);
        }

        public void Update(string id, Tarefa model)
        {
            // SELECT top(1) * FROM Tarefa WHERE Id = @id
            var tarefa = this.tarefas.SingleOrDefault(t => t.Id == id);
            tarefa.Finalizada = model.Finalizada;
            tarefa.min = model.min;
            tarefa.max = model.max;
            tarefa.umidade = model.umidade;
            tarefa.umidadeSolo = model.umidadeSolo;
            tarefa.temperatura = model.temperatura;
            tarefa.Texto = model.Texto;
        }

        public void Delete(string id)
        {
            var tarefa = this.tarefas.SingleOrDefault(t => t.Id == id);
            tarefas.Remove(tarefa);
        }
    }
}