using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Professores : ControllerBase
    {

        private readonly DataContext _contexts;

        public Professores(DataContext contexts)
        {
            _contexts = contexts;
        }


        // GET: api/<Professores>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contexts.Professores);

        }


        // GET api/<Professores>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _contexts.Professores.FirstOrDefault(a => a.ProfessorId == id);
            if (professor == null) return BadRequest("O Professor não foi Encontrado");
            return Ok(professor);
        }

        // POST api/<Professores>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _contexts.Add(professor);
            _contexts.SaveChanges();
            return Ok(professor);
        }

        // PUT api/<Professores>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _contexts.Professores.FirstOrDefault(a => a.ProfessorId == id);
            if (prof == null) return BadRequest("Professor não encontrado");

            _contexts.Update(professor);
            _contexts.SaveChanges();
            return Ok(professor);
        }


        [HttpPut("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _contexts.Professores.FirstOrDefault(a => a.ProfessorId == id);
            if (prof == null) return BadRequest("Professor não encontrado");

            _contexts.Update(professor);
            _contexts.SaveChanges();
            return Ok(professor);
        }

        // DELETE api/<Professores>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _contexts.Professores.FirstOrDefault(a => a.ProfessorId == id);
            if (prof == null) return BadRequest("Professor não encontrado");

            var profxasd = _contexts.Professores.FirstOrDefault(a => a.ProfessorId == id);
            _contexts.Remove(profxasd);
            _contexts.SaveChanges();
            return Ok(profxasd);
        }
    }





}

