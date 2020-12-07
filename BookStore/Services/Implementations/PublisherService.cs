using BookStore.Models;
using BookStore.Repositories.Interface;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Implementations
{
    public class PublisherService : IPublisherService
    {
        private IPublisherRepository publisherRepository;
        public PublisherService(IPublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }

        public List<Publisher> GetAllPublishers()
        {
            return publisherRepository.GetAll();
        }
    }
}
