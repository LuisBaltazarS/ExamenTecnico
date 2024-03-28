import { DataTypes } from "sequelize";
import connection from "../config/database.js";

const EventoModel = connection.define('EventoModel', {

    Id: {
        type: DataTypes.INTEGER,
        primaryKey: true
    },

    Name: {

        type: DataTypes.STRING,
        allowNull: false

    },

    Description: {

        type: DataTypes.STRING,
        allowNull: false

    },

    Capacity: {

        type: DataTypes.INTEGER,
        allowNull: false

    },

    StartDate: {

        type: DataTypes.DATE,
        allowNull: false

    },

    EndDate: {

        type: DataTypes.DATE,
        allowNull: false

    },

    TipoEventoId: {

        type: DataTypes.INTEGER,
        allowNull: false

    },

    SubtipoEventoId: {

        type: DataTypes.INTEGER,
        allowNull: false

    },

    OrganizadorId: {

        type: DataTypes.INTEGER,
        allowNull: false

    },

    DocenteId: {

        type: DataTypes.INTEGER,
        allowNull: false

    },

    UbicacionId: {

        type: DataTypes.INTEGER,
        allowNull: false

    }

}, {
    tableName: 'Evento',
    timestamps: false
});

export default EventoModel;