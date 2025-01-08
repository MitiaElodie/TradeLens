import axiosInstance from "@/plugins/axios";

export function getTrades() {
    return axiosInstance.get("/api/v1/trades")
        .then(response => response.data);
}

export function addTrade(trade: object) {
    return axiosInstance.post("/api/v1/trades", trade)
        .then(response => response.data);
}