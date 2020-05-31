

using AutoMapper;
using ProjectCommander.Dtos;
using ProjectCommander.Models;

namespace ProjectCommander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }



}