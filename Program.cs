using System;
using System.Threading.Tasks; 
using System.Threading;

namespace sound_project_app
{
    class Program
    {
        static async Task Main(string[] args) {
            
            var fireSamples = await SourceGetter.getFireSamples("cs_go");
            foreach (var repo in fireSamples){
                StorageManager.saveSample(repo.Gamename, "fire_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-" + repo.Name + " загружен успешно" + "\n");
            }

            var stepSamples = await SourceGetter.getStepSamples("cs_go");
            foreach (var repo in stepSamples){
                StorageManager.saveSample(repo.Gamename, "step_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-" + repo.Name + " загружен успешно" + "\n");
            }

            var explosionSamples = await SourceGetter.getExplosionSamples("cs_go");
            foreach (var repo in explosionSamples){
                StorageManager.saveSample(repo.Gamename, "explosion_samples", repo.Name, repo.Sample);
                Console.Write(repo.Gamename + "-" + repo.Name + " загружен успешно" + "\n");
            }

            var values = await SourceGetter.getValues("cs_go");
            foreach (var repo in values){
                StorageManager.saveValues(repo.Gamename, repo.Values); 
                Console.Write("Веса нейронов для игры " + repo.Gamename + " загружены успешно" + "\n");   
            }

            Console.Write("program finished!!!");
            Thread.Sleep(10000);
        }

    }
    
}
