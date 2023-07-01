using Microsoft.AspNetCore.Mvc;
using Patient_Clinic.Model;
using System.Linq.Expressions;

namespace Patient_Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientClinicController : ControllerBase
    {
        public static List<Patient> patients = new();
        private readonly ILogger<PatientClinicController> _logger;

        public PatientClinicController(ILogger<PatientClinicController> logger)
        {
            _logger = logger;
        }

        [HttpGet("DisplayPatients")]
        public IEnumerable<Patient> GetPatients()
        {
            return patients;

        }
        [HttpPost("Createpatient")]
        public Patient CreatePatient(string name, string address, int age, string injury)
        {
            var id = patients.Count() + 1;

            Patient patient = new(id, name, address, age, injury);
            patients.Add(patient);
            return patient;
        }
        [HttpPut("UpdatePatient")]
        public void UpdatePatient(int id, string NewName, string NewAddress, int NewAge, string NewInjury)
        {

            Patient NewPatient = patients.Find(patient => patient.Id == id);
            if (NewPatient != null)
            {
                NewPatient.update(NewName, NewAddress, NewAge, NewInjury);
            }
        }

        [HttpDelete("RemovePatient")]
        public void DeletePatient(int id)
        {
            Patient Patient_Done_Treatement = patients.Find(patient => patient.Id == id);
            if (Patient_Done_Treatement != null)
                patients.Remove(Patient_Done_Treatement);

        }


    }
}