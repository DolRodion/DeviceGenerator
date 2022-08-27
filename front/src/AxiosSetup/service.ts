
export class AxiosBase {
    public axios: any;

    constructor() {
        this.axios = require("axios");
    }
}

export class  DeviceService {
    static urlBase = "http://localhost:5000/api/";
    static AxiosBase = new AxiosBase();
    
    // MovieController/GetMoviesByTitle
    static async GetDevices(selectedType: string, selectedStatus : string): Promise<DeviceModel[]> {  
          
        const url = this.urlBase + "Device/GetDevices";
        const response = await this.AxiosBase.axios.get(url, {params: {selectedType: selectedType , selectedStatus: selectedStatus}});
        return response.data as DeviceModel[];
    }

    static async GetDeviceById(deviceId : string): Promise<DeviceModel> {
        const url = this.urlBase + "Device/GetDeviceById";
        const response = await this.AxiosBase.axios.get(url, {params: {deviceId: deviceId}});
        return response.data as DeviceModel;
    }
}


export class DeviceModel {
    /** Id */
    'Guid': string;

    'DeviceType': string;

    'SerialNumber': number;

    'Status': string;

    'Address': string;

    'LastActivity': Date;

    'BufferSize': number;

    'Temperature': number;


    constructor(data: undefined | any = {}) {
        this['Guid'] = data['Guid'];
        this['DeviceType'] = data['DeviceType'];
        this['SerialNumber'] = data['SerialNumber'];
        this['Status'] = data['v'];
        this['Address'] = data['Address'];   
        this['LastActivity'] = data['LastActivity'];   
        this['BufferSize'] = data['BufferSize'];   
        this['Temperature'] = data['Temperature'];       
    }
    public static validationModel = {};
}
