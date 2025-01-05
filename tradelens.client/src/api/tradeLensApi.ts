import axiosInstance from "@/plugins/axios";

export function getTrades() {
    return axiosInstance.get("/api/v1/trades")
        .then(response => response.data);
}