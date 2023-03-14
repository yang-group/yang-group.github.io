<template>
    <div style="height:100%; width:100%; margin-top: 88px;">
        <iframe :src=src frameborder="0" width="100%" height="800px" scrolling="auto" ></iframe>
    </div>
</template>
<script>
export default {
  props: { src: String },
  data: () => ({
    src: ''
  }),
  mounted () {
    this.src = 'projectpage/MobileHCI2023/index.html'
  }
}
</script>
