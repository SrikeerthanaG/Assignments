using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crime_Analysis_and_Reporting_System.Entity;

namespace Crime_Analysis_and_Reporting_System.Businesslayer
{
    public interface ICrimeAnalysisService
    {
        // Create a new incident
        bool CreateIncident(Incident incident);

        // Update the status of an incident
        bool UpdateIncidentStatus(string status, int incidentID);

        // Get a list of incidents within a date range
        List<Incident> GetIncidentsInDateRange(DateTime startDate, DateTime endDate);

        // Search for incidents based on various criteria
        List<Incident> SearchIncidents(string incidentType);

        // Generate incident reports
        Report GenerateIncidentReport(Incident incident);

        // Create a new victim
        bool CreateVictim(Victim victim);

        // Create a new suspect
        bool CreateSuspect(Suspect suspect);

        // Other entity-related methods (Law Enforcement Agencies, Officer, Evidence, etc.)
        bool CreateOfficer(Officer officer);
        bool CreateLawEnforcementAgency(LawEnforcementAgency agency);
        bool CreateEvidence(Evidence evidence);
        bool CreateReport(Report report);
    }
}
