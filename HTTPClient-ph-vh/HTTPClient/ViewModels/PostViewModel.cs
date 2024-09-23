using CommunityToolkit.Mvvm.ComponentModel;
using HTTPClient.Models;
using HTTPClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTPClient.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Post> posts;

        private ICommand getPostsCommad { get; }


        public async void getPosts()
        {
           PostService postService = new PostService();
           posts = await postService.getPosts();
        }
    }
}
