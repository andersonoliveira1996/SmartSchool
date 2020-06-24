using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   
    public class Alunos : ControllerBase
    {
        private readonly DataContext _contexts;

        public Alunos(DataContext contexts) 
        {
            _contexts = contexts;
        }



        // GET: api/<Aluno>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contexts.Alunos);

        }


        // GET api/<Aluno>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {   
            var aluno = _contexts.Alunos.FirstOrDefault(a => a.AlunooId == id);
            if (aluno == null) return BadRequest("O Aluno não foi Encontrado");
            return Ok(aluno);
        }

        // POST api/<Aluno>
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _contexts.Add(aluno);
            _contexts.SaveChanges();
            return Ok(aluno);
        }

        // PUT api/<Aluno>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _contexts.Alunos.FirstOrDefault(a => a.AlunooId == id);
            if (alu == null) return BadRequest("Aluno não encontrado");

            _contexts.Update(aluno);
            _contexts.SaveChanges();
            return Ok(aluno);
        }


        [HttpPut("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _contexts.Alunos.FirstOrDefault(a => a.AlunooId == id);
            if (alu == null) return BadRequest("Aluno não encontrado");

            _contexts.Update(aluno);
            _contexts.SaveChanges();
            return Ok(aluno);
        }

        // DELETE api/<Aluno>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var alu = _contexts.Alunos.FirstOrDefault(a => a.AlunooId == id);
            if (alu == null) return BadRequest("Aluno não encontrado");

            var alunoxasd = _contexts.Alunos.FirstOrDefault(a => a.AlunooId == id);
            _contexts.Remove(alunoxasd);
            _contexts.SaveChanges();
            return Ok(alunoxasd);
        }
    }
}
