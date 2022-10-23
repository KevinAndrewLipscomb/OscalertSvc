// Derived from KiAspdotnetFramework/component/biz/Class~biz~~template~kicrudhelped~item.cs~template

using Class_biz_incident_nature_translations;
using Class_db_cad_records;
using OscalertSvc.Models;
using System;

namespace Class_biz_cad_records
  {
  public class TClass_biz_cad_records : ObjectBiz
    {

    private readonly TClass_biz_incident_nature_translations biz_incident_nature_translations = null;
    private readonly TClass_db_cad_records db_cad_records = null;

    public TClass_biz_cad_records() : base()
      {
      biz_incident_nature_translations = new TClass_biz_incident_nature_translations();
      db_cad_records = new TClass_db_cad_records();
      }

    internal void Augment()
      {
      db_cad_records.Augment();
      }

    internal string LocalRenditionOf(string nature)
      {
      var active_case_board_rendition_of = nature;
      var local_rendition = biz_incident_nature_translations.LocalOfForeign(nature);
      if (local_rendition.Length > 0)
        {
        active_case_board_rendition_of = local_rendition;
        }
      return active_case_board_rendition_of;
      }

    public bool Delete(string id)
      {
      return db_cad_records.Delete(id);
      }

    public bool Get
      (
      string id,
      out DateTime incident_date,
      out string incident_num,
      out string incident_address,
      out string call_sign,
      out DateTime time_initialized,
      out DateTime time_of_alarm,
      out DateTime time_enroute,
      out DateTime time_on_scene,
      out DateTime time_transporting,
      out DateTime time_at_hospital,
      out DateTime time_available,
      out DateTime time_downloaded
      )
      {
      return db_cad_records.Get
        (
        id,
        out incident_date,
        out incident_num,
        out incident_address,
        out call_sign,
        out time_initialized,
        out time_of_alarm,
        out time_enroute,
        out time_on_scene,
        out time_transporting,
        out time_at_hospital,
        out time_available,
        out time_downloaded
        );
      }

    public void Set
      (
      string id,
      string incident_date,
      string incident_num,
      string incident_address,
      string call_sign,
      string time_initialized,
      string time_of_alarm,
      string time_enroute,
      string time_on_scene,
      string time_transporting,
      string time_at_hospital,
      string time_available,
      string time_downloaded,
      string nature
      )
      {
      db_cad_records.Set
        (
        id,
        incident_date,
        incident_num,
        incident_address,
        call_sign,
        time_initialized,
        time_of_alarm,
        time_enroute,
        time_on_scene,
        time_transporting,
        time_at_hospital,
        time_available,
        time_downloaded,
        nature
        );
      }

    public object Summary(string id)
      {
      return db_cad_records.Summary(id);
      }

    public void ValidateAndTrim()
      {
      db_cad_records.ValidateAndTrim();
      }

    } // end TClass_biz_cad_records

  }
