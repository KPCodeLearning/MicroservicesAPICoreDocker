﻿using System.Linq;
using APICoreDocker.DBContext;
using APICoreDocker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APICoreDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentContext _context;
        public StudentController(IStudentContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChanges();
            return Ok(student.Id);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _context.Students.ToListAsync();
            if (students == null) return NotFound();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _context.Students.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (student == null) return NotFound();
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (student == null) return NotFound();
            _context.Students.Remove(student);
            await _context.SaveChanges();
            return Ok(student.Id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Student studentUpdate)
        {
            var student = _context.Students.Where(a => a.Id == id).FirstOrDefault();
            if (student == null) return NotFound();
            else
            {
                student.Age = studentUpdate.Age;
                student.Name = studentUpdate.Name;
                await _context.SaveChanges();
                return Ok(student.Id);
            }
        }
    }
}