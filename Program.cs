using System;
using System.Threading.Tasks; 
using System.Threading;

namespace sound_project_app
{
    class Program
    {
        static async Task Main(string[] args) {
            
            Console.WriteLine("Введите название игры: ");
            string inName = Console.ReadLine();

            var fireSamples = await SourceGetter.getFireSamples(inName);
            foreach (var repo in fireSamples){
                StorageManager.saveSample(repo.Gamename, "fire_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-fire-" + repo.Name + " загружен успешно" + "\n");
            }

            var stepSamples = await SourceGetter.getStepSamples(inName);
            foreach (var repo in stepSamples){
                StorageManager.saveSample(repo.Gamename, "step_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-step-" + repo.Name + " загружен успешно" + "\n");
            }

            var explosionSamples = await SourceGetter.getExplosionSamples(inName);
            foreach (var repo in explosionSamples){
                StorageManager.saveSample(repo.Gamename, "explosion_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-explosion-" + repo.Name + " загружен успешно" + "\n");
            }

            var values = await SourceGetter.getValues(inName);
            foreach (var repo in values){
                StorageManager.saveValues(repo.Gamename, repo.Values); 
                Console.Write("Веса нейронов для игры " + repo.Gamename + " загружены успешно" + "\n");   
            }

            Console.Write("program finished!!! Press any key to close the window");
            Console.ReadKey();
        }

    }
    
}
