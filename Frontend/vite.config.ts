import { defineConfig } from "vite";
import react from "@vitejs/plugin-react-swc";

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
  // build: {
  //   rollupOptions: {
  //     output: {
  //       dir: "../wwwroot/dist",
  //       entryFileNames: "index.js",
  //       assetFileNames: "index.css",
  //       chunkFileNames: "chunk.js",
  //       manualChunks: undefined,
  //     },
  //     external: "react",
  //   },
  // },
});
