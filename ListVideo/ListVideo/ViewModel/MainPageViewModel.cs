using System;
using System.Collections.ObjectModel;
using ListVideo.Models;

namespace ListVideo.ViewModel
{
    public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<ItemModel> _list;
        public ObservableCollection<ItemModel> List
        {
            get { return _list; }
            set { SetProperty(ref _list, value); }
        }
        public MainPageViewModel()
        {
            List = new ObservableCollection<ItemModel>();
            List.Clear();
            List.Add(new ItemModel
            {
                UrlString = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
                IsVideo = true
            });

            List.Add(new ItemModel
            {
                UrlString = "plant.jpg",
                IsVideo = false
            });

            List.Add(new ItemModel
            {
                UrlString = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
                IsVideo = true
            });

            List.Add(new ItemModel
            {
                UrlString = "plant.jpg",
                IsVideo = false
            });

            List.Add(new ItemModel
            {
                UrlString = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
                IsVideo = true
            });

            List.Add(new ItemModel
            {
                UrlString = "plant.jpg",
                IsVideo = false
            });

            List.Add(new ItemModel
            {
                UrlString = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4",
                IsVideo = true
            });

            List.Add(new ItemModel
            {
                UrlString = "plant.jpg",
                IsVideo = false
            });
        }
    }
}
