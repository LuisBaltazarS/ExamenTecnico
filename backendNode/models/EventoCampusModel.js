import { DataTypes, INTEGER } from "sequelize";
import connection from "../config/database.js";

const EventoCampusModel = connection.define('EventoCampusModel', {

    EventoId: {
        type: DataTypes.INTEGER,
        primaryKey: true
    },

    CampusId: {
        type: DataTypes.INTEGER,
        primaryKey: true
    }

})

export default EventoCampusModel;