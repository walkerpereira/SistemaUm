using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaUm.Data;
using SistemaUm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaUm.Services
{
    public class AlunoService
    {
        private readonly SistemaUmContext _context;

        public AlunoService(SistemaUmContext context)
        {
            _context = context;
        }
        public async Task<List<Aluno>> FindAllByAsync()
        {
            return await _context.Aluno.ToListAsync();
        }
        public async Task InsertAsync(Aluno obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
