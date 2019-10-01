using System;
using ListVideo.Models;
using ListVideo.Views.Template;
using Xamarin.Forms;

namespace ListVideo.ViewModel
{
    public class ListDataTemplate : DataTemplateSelector
    {
        public ListDataTemplate()
        {
            // Retain instances!
            this.isVideoDataTemplate = new DataTemplate(typeof(VideoViewTemplate));
            this.isImageDataTemplate = new DataTemplate(typeof(ImageViewTemplate));
        }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as ItemModel;
            if (messageVm.IsVideo)
            {
                return isVideoDataTemplate;
            }
            else
            {
                return isImageDataTemplate;
            }
        }

        private readonly DataTemplate isVideoDataTemplate;
        private readonly DataTemplate isImageDataTemplate;
    }
}
