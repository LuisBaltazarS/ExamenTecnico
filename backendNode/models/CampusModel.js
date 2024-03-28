import { DataTypes } from "sequelize";
import connection from "../config/database.js";

const CampusModel = connection.define('CampusModel', {

    Id: {
        type: DataTypes.INTEGER,
        primaryKey: true
    },

    Name: {

        type: DataTypes.STRING,
        allowNull: false

    }

}, {
    tableName: 'Campus',
    timestamps: false
});

export default CampusModel;