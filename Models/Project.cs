using Microsoft.AspNetCore.Components;

namespace GiovanniBlazorWebAppE.Models
{
    public class Project
    {
        public string projectTitle { get; set; }
        public string projectDescription { get; set; }
        public string projectLink { get; set; }
        public string projectImg { get; set; }
        public string projectImgAlt { get; set; }
        public string projectImgId { get; set; }
    }
}

/*< Project ProjectTitle = "Energy Data Analysis (Python)"
                     ProjectDesc = "Demonstrates exploratory data analysis skills using data from world energy. Utilizies Python and Shiny to create a simple data driven application."
                     ProjectLink = "https://github.com/garatico/GiovanniBlazorWebApp"
                     ProjectImg = "../img/shiny-python.png"
                     ProjectImgAlt = "Python Shiny"
                     ProjectImgId = "pyshypic" />
            < !--PROJECT 3 / BLAZOR WEB APP -->
            <Project ProjectTitle="Personal Web App Blazor"
                     ProjectDesc="Demonstrates basics of web frameworks in a front-end focus using Blazor and C#. Utilizies Razor components and ability to deploy simple application."
                     ProjectLink="https://github.com/garatico/GiovanniBlazorWebApp"
                     ProjectImg="../img/blazor-logo.png"
                     ProjectImgAlt="Blazor App"
                     ProjectImgId="blazorpic"/>
            <!-- PROJECT 2 / METACRITIC-->
            <Project ProjectTitle="Metacritic Webscraper"
                     ProjectDesc="Demonstrates basic programming skills in Python. Utilitizes the libraries Requests, NumPy and BeautifulSoup to collect data and output to usable formats."
                     ProjectLink="https://github.com/garatico/Metacritic-Scraper"
                     ProjectImg="../img/meta.png"
                     ProjectImgAlt="Metacritic"
                     ProjectImgId="metapic"/>
            <!-- PROJECT 1-->
            <Project ProjectTitle="Personal Website"
                     ProjectDesc="Demonstrates basic web development skills including HTML, CSS and JavaScript in a static web app. Utilitizes Bootstrap styling and demonstrates knowledge of git version control."
                     ProjectLink="https://github.com/garatico/garatico.github.io"
                     ProjectImg="../img/face.jpg"
                     ProjectImgAlt="Giovanni"
                     ProjectImgId="facepic" />

*/