import axiosInstance from "@/plugins/axios";

export function getTrades() {
    return axiosInstance.get("/WeatherForecast")
        .then(response => response.data);
}