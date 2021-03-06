﻿using System;
using System.Collections.Generic;
using MovieNews.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace MovieNews.ViewModels
{
    public class MoviesDetailsViewModel: BindableBase,INavigatingAware
    {
        public MoviesDetailsViewModel()
        {
        }

        readonly MoviesDetailsManager managerMoviesDetail = new MoviesDetailsManager();

        private Models.MoviesNewClass.Result _movie;
        public Models.MoviesNewClass.Result Movie
        {
            get { return _movie; }
            set { SetProperty(ref _movie, value); }
        }


        private List<MovieResult> _details;

        public List<MovieResult> Details
        {
            get { return _details; }
            set { SetProperty(ref _details, value); }
        }

        private string _release;

        public string Release
        {
            get { return _release; }
            set { SetProperty(ref _release, value); }
        }
        private string _titles;

        public string Titles
        {
            get { return _titles; }
            set { SetProperty(ref _titles, value); }
        }
        private string _genre;

        public string Genre
        {
            get { return _genre; }
            set { SetProperty(ref _genre, value); }
        }

        private string _overview;

        public string Overview
        {
            get { return _overview; }
            set { SetProperty(ref _overview, value); }
        }

        private string _overviews;

        public string Overviews
        {
            get { return _overviews; }
            set { SetProperty(ref _overviews, value); }
        }

        private string _img;

        public string Img
        {
            get { return _img; }
            set { SetProperty(ref _img, value); }
        }

        public async void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("movies"))
            {
                Movie = parameters.GetValue<Models.MoviesNewClass.Result>("movies");
                var detailsMovie = await managerMoviesDetail.GetAllDetail(Movie);

                foreach (var b in detailsMovie.genres)
                {
                    Genre = b.name;
                }
                Titles = detailsMovie.title;
                Release = detailsMovie.release_date;
                Overviews = detailsMovie.overview;
                Img = "https://image.tmdb.org/t/p/w500"+detailsMovie.poster_path;
            }
        }

      
    }
}
