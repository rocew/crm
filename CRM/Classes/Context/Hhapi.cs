using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class HhApi
{
    private static readonly string ApiUrl = "https://api.hh.ru";

    public static async Task<string> GetResumesAsync(string accessToken)
    {
        using (HttpClient client = new HttpClient())
        {
            // Добавляем токен в заголовок запроса
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            // Делаем запрос к API для получения списка резюме
            HttpResponseMessage response = await client.GetAsync($"{ApiUrl}/resumes/mine");

            // Проверяем успешность запроса
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Ошибка при запросе к API: {response.StatusCode}");
            }
        }
    }
}

public class Resume
{
    public string Id { get; set; }
    public string Title { get; set; }
    // Добавьте другие поля, которые вам нужны
}

public class ResumeResponse
{
    public List<Resume> Items { get; set; }
}

public static class ResumeParser
{
    public static List<Resume> ParseResumes(string json)
    {
        return JsonConvert.DeserializeObject<ResumeResponse>(json)?.Items ?? new List<Resume>();
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        string accessToken = "USERKJJ763CBOFHD8BIU46VOSMVB29Q91JD9SLUKOKIFI0SOPI4UT0I8TAON0K5C"; // Замените на ваш токен

        try
        {
            // Загружаем резюме
            string resumesJson = await HhApi.GetResumesAsync(accessToken);

            // Парсим JSON в объекты C#
            List<Resume> resumes = ResumeParser.ParseResumes(resumesJson);

            // Выводим информацию о резюме
            foreach (var resume in resumes)
            {
                Console.WriteLine($"Resume ID: {resume.Id}, Title: {resume.Title}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}