﻿using DefectDojoJob.Models.Processor;

namespace DefectDojoJob.Services.Interfaces;

public interface IUsersProcessor
{
    public Task<UsersProcessingResult> ProcessUsersAsync(List<string> userNames);
    public Task<AssetToDefectDojoMapper> ProcessUserAsync(string username);

}