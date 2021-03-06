﻿using System;

using NHibernate;

using MeaData;
using MEACruncher.Resources;

namespace MEACruncher {

    internal class EntityManager {
        // ENCAPSULATED FIELDS
        private ISession _db;

        // INTERFACE
        public EntityManager(ISession db) {
            _db = db;
        }

        // DELETE ENTITY WARNINGS
        public string DeleteWarningMsg(Project entity) {
            return String.Format(DeleteRes.Project, entity.Name);
        }

        // DUPLICATE ENTITY ERROR MESSAGES
        public string DuplicateErrorMsg(Project entity) {
            string msg = String.Format(
                            DuplicateRes.Project,
                            entity.Name,
                            entity.DateStarted.ToShortDateString());
            msg += ("\n" + DuplicateRes.Message);
            return msg;
        }

        // TEST ENTITIES FOR UNIQUENESS
        public bool IsUnique(Project entity) {
            int count = _db.QueryOver<Project>()
                           .Where(e =>
                               e.Guid != entity.Guid &&
                               e.Name == entity.Name &&
                               e.DateStarted == entity.DateStarted)
                           .RowCount();
            return (count == 0);
        }
        
    }

}