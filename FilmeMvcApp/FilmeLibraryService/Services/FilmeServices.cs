﻿using System;
using System.Collections.Generic;
using FilmeLibraryService.Models;
using FilmeLibraryService.Repository;

namespace FilmeLibraryService.Services
{
    public static class FilmeServices
    {
        private static FilmsRepository filmsRepository = new FilmsRepository();


        public static List<Custommer> GetByCustomerProp()
        {
            return filmsRepository.GetByCustomerProp();
        }



        public static Film GetById(int Id)
        {
            return filmsRepository.GetByID(Id);
        }

        public static List<Film> GetAll()
        {
            return filmsRepository.GetAll();
        }

        public static List<Film> GetByCategory(string Category)
        {
            return filmsRepository.GetByCategory(Category);
        }

        public static List<Film> GetByName(string Name)
        {
            return filmsRepository.GetByName(Name);
        }

        public static List<string> GetAllCategory()
        {
            return filmsRepository.GetAllCategory();
        }


        /// <summary>
        /// Wirck with contewnt of repository
        /// </summary>
        /// <param name="film">Film.</param>
        /// 

        public static void DeleteFilm(Film film)
        {
            filmsRepository.DeleteFilm(film);
        }
        public static void AddFilm(Film film)
        {
            filmsRepository.AddFilm(film);
        }


        public static void UpdateFilm(Film film)
        {
            filmsRepository.UpdateFilm(film);
        }

    }
}
