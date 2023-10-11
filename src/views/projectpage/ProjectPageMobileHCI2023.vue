<template>
    <div style="height:2000px; width:100%; margin-top: 88px;">
        <iframe :src=src frameborder="0" width="100%" height="100%" scrolling="auto" ></iframe>
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
